# Unit testing tasks

## All Users: Output and Adding More Tests
We know now how the test runner behaves when a test passes and can begin the real work of unit testing the Car class. One responsibility of the Car class constructor is to set its initial gasTankLevel field. This field is determined by the constructor argument for gasTankSize.

Car.cs:
```
// Gas tank level defaults to a full tank
GasTankLevel = gasTankSize;
```

This class-specific behavior is a good item to test. Under your second TODO, write a test to verify that the constructor sets the gasTankLevel field.

## TestGasTankAfterDriving()
Add a test for the third TODO, “GasTankLevel is accurate after driving within tank range”.

Your test must use the Car method Drive()

`test_car.Drive(50);`

With a value of 50 miles passed into Drive(), we expect test_car to have a GasTankLevel of 9.

`Assert.AreEqual(9, test_car.GasTankLevel, .001);`

## TestGasTankAfterExceedingTankRange()
Add a test for the fourth TODO, “GasTankLevel is accurate after attempting to drive past tank range”.

You’re on your own for this one. You’ll need to simulate the Car travelling farther than it’s gasTankLevel allows.

## TestGasOverfillException()
The test for our last TODO is a little different. We are going to perform an action on our car object, and we are expecting the object to throw an error. In this case, we are going to attempt to add gas to our car that exceeds the gas tank size.

1. Update the Car class to include an AddGas() method.
2. Back in CarTests, implement the new AddGas() method and a Assert.Fail() scenario.
3. Run the test. It should fail! In the output log, we can see our Assert.Fail() statement about not being able to add more gas printed out.
4. We need to refactor Car to throw an exception when too much gas is added to the tank. Find the AddGas() method and modify it by adding the following code in the appropriate place.

```
if (GasTankLevel > GasTankSize)
{
   throw new ArgumentOutOfRangeException("Can't exceed tank size");
}
```
