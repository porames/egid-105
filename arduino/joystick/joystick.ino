void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(2, INPUT_PULLUP);
  pinMode(LED_BUILTIN, OUTPUT);
}
unsigned long previousMillis = 0;
int ledState = LOW;
int countPressed = 0;
boolean lastSw;
int state = 0;
void loop() {
  // put your main code here, to run repeatedly:
  unsigned long Vx = analogRead(0);
  unsigned long Vy = analogRead(1);
  int sw = digitalRead(2);
  int freq;
  int xDeg=map(Vx,0,1023,0,180);
  int yDeg=map(Vy,0,1023,0,180);
  Serial.print(xDeg);  
  Serial.print(", ");
  Serial.println(yDeg); 

  if (sw && !lastSw) {
    countPressed++;
    state = countPressed % 3;
    Serial.println(state);
  }

  if (state != 2) {
    if (state == 0) {
      freq = 250;
    }
    else if (state == 1) {
      freq = 1000;
    }
    unsigned long currentMillis = millis();
    if (currentMillis - previousMillis >= freq) {
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
  lastSw = sw;

}
