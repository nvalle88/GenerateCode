Easy to use generate number is useful to generate random numbers within a range.

Example of use
We have the possibility to configure the maximum and the minimum so that the random number is within the established range. This is thought in
applications where the maximum and the minimum do not have a lot of variation in the life time of the application.
for that we have the following static variables

      GenerateNumber.Lower = 10;
      GenerateNumber.Top = 25;
the next method that takes as reference the aforementioned variables

      GenerateNumber.Generate ()
the previous method returns the integer random number.

the previous method how much with an overload which we passed the maximum and the minimum of our range

      GenerateNumber.Generate (10,66)
this overload returns the integer random number.
