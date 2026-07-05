// Define RGB LED pins
int redPin = 4;    // Red LED
int greenPin = 5;  // Green LED
int bluePin = 6;   // Blue LED

// Define sensor pins
int soundSensor = 2;  // Sound sensor
int motionSensor = 3; // Motion sensor
int lightSensor = A0; // Light sensor

// State variables and debounce settings
bool isLEDOn = false; // LED state
unsigned long lastDebounceTime = 0;
unsigned long debounceDelay = 300; // Debounce duration

void setup() {
  pinMode(soundSensor, INPUT);
  pinMode(motionSensor, INPUT);
  pinMode(lightSensor, INPUT);
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);

  turnOffLEDs();
}

void loop() {
  unsigned long currentTime = millis();

  // Sound sensor triggers LED toggle
  if (digitalRead(soundSensor) == HIGH) {
    if (currentTime - lastDebounceTime > debounceDelay) {
      lastDebounceTime = currentTime;
      isLEDOn = !isLEDOn;

      if (isLEDOn) {
        setLEDColor(255, 255, 255); // White LED
      } else {
        turnOffLEDs();
      }
    }
  }

  // Motion sensor triggers LED blinking
  if (isLEDOn && digitalRead(motionSensor) == HIGH) {
    if (currentTime - lastDebounceTime > debounceDelay) {
      lastDebounceTime = currentTime;
      blinkLEDs();
      setLEDColor(255, 255, 255); // Restore white LED after blinking
    }
  }

  // Adjust brightness based on ambient light
  if (isLEDOn) {
    int lightLevel = analogRead(lightSensor);
    int brightness = map(lightLevel, 0, 1023, 0, 255);
    adjustLEDBrightness(brightness);
  }
}

// Function to turn off LEDs
void turnOffLEDs() {
  analogWrite(redPin, 0);
  analogWrite(greenPin, 0);
  analogWrite(bluePin, 0);
}

// Function to set LED color
void setLEDColor(int red, int green, int blue) {
  analogWrite(redPin, red);
  analogWrite(greenPin, green);
  analogWrite(bluePin, blue);
}

// Function to blink LEDs in sequence
void blinkLEDs() {
  setLEDColor(255, 0, 0); // Red
  delay(200);
  setLEDColor(0, 255, 0); // Green
  delay(200);
  setLEDColor(0, 0, 255); // Blue
  delay(200);
}

// Function to adjust LED brightness
void adjustLEDBrightness(int brightness) {
  analogWrite(redPin, brightness);
  analogWrite(greenPin, brightness);
  analogWrite(bluePin, brightness);
}
