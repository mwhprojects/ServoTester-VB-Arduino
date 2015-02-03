/*********************************************
 * Servo Tester for Arduino
 *********************************************
 * This program connects to an Arduino via a serial connection. From the VB program, you can select a pin
 * a servo is connected to and the position, or speed if it is a continuous rotation servo.
 * 
 * https://github.com/mwhprojects/ServoTester-VB-Arduino
 *********************************************/

// Servo library.
#include <Servo.h> 
Servo userservo;

// This variable is used to store the data coming from the Visual Basic program.
String receivedData;
// These variables are used to split up the data for easier processing.
String pinSelect, servoSpeed;

void setup(){
  // Open a serial connection at 9600 baud.
  Serial.begin(9600);
}

void loop()
{
  // Wait until serial data is coming in from the Visual Basic program.
  while(Serial.available()) {
    // Once there is serial data in the buffer, we give it time to let the buffer fill up.
    delay(3);

    // Read the first character in the buffer to the variable 'c'.
    char c = Serial.read();
    Serial.println(c);
    // Add the character to the receivedData string variable.
    receivedData += c; 

    // Repeat until there is no more data on the buffer.
  }

  if(receivedData.length() != 5){
    // If there is not the right number of characters in the string, throw it out.
    receivedData = "";
  }
  else{

    // Split the string into two variables. The first variable is for the pin number which is 2 characters. 
    // Use "substring" to cut the string. This takes the character at positions 0 and 1.
    pinSelect = receivedData.substring(0, 2);
    // Remember that so far we have been working with a string and characters. Convert the string into integers..
    int pinSelectInt = pinSelect.toInt();
    // Set up the servo pin for use.
    userservo.attach(pinSelectInt);

    // Do the same thing for the second variable, the servo speed. We're taking the last 3 characters of the string.
    // Again, use "substring", this time taking the characters at positions 2 to 5.
    servoSpeed = receivedData.substring(2, 6);
    // Convert it into an integer.
    int servoSpeedInt = servoSpeed.toInt();

    // Clear the string, just to clean up for the next cycle.
    receivedData = "";

    // Set the servo speed!
    userservo.write(servoSpeedInt);
  }
}


