namespace Oil_level_glass.Enums
{
    enum InputError
    {
        None = 0,

        EmptyField = 1,

        BigName = 2,

        BadPath = 3,

        InvalidType = 4,

        TooSmallNumber = 5,

        TooBigNumber = 6,

        BrokenStrictHierarchy = 7,

        BrokenHierarchy = 8,

        ZeroOrNegative = 9,

        NotUniqueName = 10,

        LessMinDensity = 11,

        BiggerMaxDensity = 12
    }
}
