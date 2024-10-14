using System.ComponentModel;

namespace korobkov_winforms_DGV
{
    /// <summary>
    /// Направления для туров
    /// </summary>
    public enum Destination
    {
        [Description("Турция")]
        Turkey = 1,

        [Description("Испания")]
        Spain = 2,

        [Description("Италия")]
        Italy = 3,

        [Description("Франция")]
        France = 4,

        [Description("Шушары")]
        Shushary = 5,
    }
}
