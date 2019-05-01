using System;

namespace dotnet.Interfaces
{
    // Seriously dotnet people, what's all this with everything needing an interface?
    // It's like C++ header files, but now with more OO crap.
    // Yeah I know you do this in Java as well, shut it.
    public interface IFibService
    { // Look at this brackets on another line rubbish, get a hobby instead of hitting return all the time.
        // PascalCase is just so wrong
        long GetFibN(int n);

        // Faster version, using closed form algo
        long GetFibNFast(int n);
    }
}