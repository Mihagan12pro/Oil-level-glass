using Oil_level_glass.Enums;

namespace Oil_level_glass.Delegates
{
    internal delegate void ErrorAdder(string prop, string errorMessage, InputError errorType);

    internal delegate void ErrorClearer(string prop);
}
