namespace IdleRpgAction.Domain.Enumerations
{
    public enum RouletteGameEnum
    {
        /// <summary>
        /// Chose a number
        /// </summary>
        Plein,
        /// <summary>
        /// 1-18
        /// </summary>
        Manque,
        /// <summary>
        /// All odd numbers
        /// </summary>
        Impair,
        /// <summary>
        /// 19-36
        /// </summary>
        Passe,
        /// <summary>
        /// All even numbers
        /// </summary>
        Pair,
        /// <summary>
        /// All black numbers
        /// </summary>
        Noir,
        /// <summary>
        /// 1-12
        /// </summary>        
        Premier,
        /// <summary>
        /// 13-24
        /// </summary>
        Milieu,
        /// <summary>
        /// 25-36
        /// </summary>
        Dernier
    }
}
