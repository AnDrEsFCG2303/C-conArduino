#include <Stepper.h>
#include <NewPing.h>

#define TRIGGER_PIN 6
#define ECHO_PIN 7
#define MAX_DIST 200

int pasosPorVuelta = 2048;
Stepper motor(pasosPorVuelta, 8, 10, 9, 11);
NewPing sonar(TRIGGER_PIN, ECHO_PIN, MAX_DIST);

bool modoAutomatico = false;
int posicionActual = 0;

void setup() {
    Serial.begin(9600);
    motor.setSpeed(5);
}

// Función para mover el motor en modo manual
void moverMotorManual(int grados) {
    int pasos = map(abs(grados), 0, 360, 0, pasosPorVuelta);
    int direccion = (grados < 0) ? -1 : 1;

    for (int i = 0; i < abs(grados); i++) {
        motor.step(direccion * (pasos / abs(grados))); // Mueve 1 grado
        posicionActual += direccion;
        enviarDatos(); // Enviar datos en cada paso
    }
}

// Función para activar el modo automático
void activarModoAutomatico() {
    modoAutomatico = true;
}

// Función para manejar la entrada serial
void procesarComando(String entrada) {
    entrada.trim();
    if (entrada == "A") {
        activarModoAutomatico();
    } else {
        int grados = entrada.toInt();
        if (grados != 0) {
            modoAutomatico = false;
            moverMotorManual(grados);
        }
    }
}

// Función para enviar datos (posición y distancia)
void enviarDatos() {
    int distancia = sonar.ping_cm();
    Serial.print(posicionActual);
    Serial.print(",");
    Serial.println(distancia);
}

void loop() {
    if (Serial.available() > 0) {
        String entrada = Serial.readStringUntil('\n');
        procesarComando(entrada);
    }

    if (modoAutomatico) {
        int pasosPorGrado = pasosPorVuelta / 360;

        // Mover hacia adelante 180°
        for (int i = 0; i < 365; i++) {
            motor.step(pasosPorGrado);
            posicionActual++;
            enviarDatos(); // Enviar datos en cada paso
        }
        delay(1000);

        // Mover hacia atrás 180°
        for (int i = 0; i < 365; i++) {
            motor.step(-pasosPorGrado);
            posicionActual--;
            enviarDatos(); // Enviar datos en cada paso
        }
        delay(1000);
    }

    // Si el motor está quieto, seguir enviando datos del sensor
    enviarDatos();
    delay(100);
}
