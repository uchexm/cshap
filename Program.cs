﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if(daysUntilExpiration <= 10){
  Console.WriteLine("Your subscription will expire soon. Renew now!");
}else if (daysUntilExpiration <= 5){
  Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
  discountPercentage = 10;
}else if(daysUntilExpiration <= 1){
  Console.WriteLine("Your subscription expires within a day!");
discountPercentage = 20;
}else if(daysUntilExpiration == 0){
  Console.WriteLine("Your subscription has expired.");
}
else Console.WriteLine(discountPercentage);