using StaticExercise;

double fahrenheitTempToConvert = 50;
var celciusTemp = TempConverter.FahrenheitToCelsius(fahrenheitTempToConvert);
Console.WriteLine($"{fahrenheitTempToConvert} degrees Fahrenheit = {celciusTemp} degrees Celcius");

double celciusTempToConvert = 35;
var fahrenheitTemp = TempConverter.CelsiusToFahrenheit(celciusTempToConvert);
Console.WriteLine($"{celciusTempToConvert} degrees Celsius = {fahrenheitTemp} degrees Fahrenheit");