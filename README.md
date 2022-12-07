# Duck-Hunt-2

This build did not have time to implement killing ducks. It only uses the command pattern.

We use the command pattern was implemented by creating an Input Handler called Input Commands.
It keeps an array of command abstracts, with each element of the array being a different subclass of the command abstract.

Each command has a reference to the crosshair game object, as is assigned a specific function.
When we press a key, we access the array at a specific location, based on the command that we want.
For example, W accesses the 0 index of the array, so by default we store the Up command at 0. 
We then use the abstract virtual function Execute() to execute the override of the specific subclass.

When we detect that 2 birds have escaped, we swap the commands placed in array index 0 and array index 1. 
This allows us to quickly and easily swap the controls with remapping instead of variables,
which may be preferencial for intentional remapping.