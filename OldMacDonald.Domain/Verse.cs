namespace OldMacDonald.Domain
{
    #region

    using System.Text;

    #endregion

    public static class Verse
    {
        public static StringBuilder GetDefaultVerse()
        {
            return
                new StringBuilder(
                    "Old MacDonald had a farm, E I E I O,@newLine"
                    + "And on his farm he had a @animal, E I E I O.@newLine"
                    + "With a @sound @sound here and a @sound @sound there,@newLine"
                    + "Here a @sound, there a @sound, ev'rywhere a @sound @sound.@newLine"
                    + "Old MacDonald had a farm, E I E I O.@newLine");
        }
    }
}