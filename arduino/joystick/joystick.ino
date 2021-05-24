void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(2, INPUT_PULLUP);
  pinMode(LED_BUILTIN, OUTPUT);
}
unsigned long previousMillis = 0;
int ledState = LOW;
void loop() {
  // put your main code here, to run repeatedly:
  unsigned long Vx = analogRead(0);
  unsigned long Vy = analogRead(1);
  int sw = digitalRead(2);
  Serial.print("Vx: ");
  Serial.print(Vx);
  Serial.print(" Vy: ");
  Serial.print(Vy);
  Serial.print(" sw: ");
  Serial.println(sw);
  if (sw == 1) {
    unsigned long currentMillis = millis();
    if (currentMillis - previousMillis >= 1000) {
      previousMillis = currentMillis;
      if (ledState == LOW) {
        ledState = HIGH;
      }
      else {
        ledState = LOW;
      }
      digitalWrite(LED_BUILTIN, ledState);
    }
  }
  else{
      ledState = LOW;
      digitalWrite(LED_BUILTIN, ledState);
  }

}
