using VideoGame;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        Character goodGuy = new Character();
        Character badGuy = new Character();

        goodGuy.name = "Goku";
        goodGuy.lifePoints = 10;
        goodGuy.attackForce = 9001;
        goodGuy.defenseForce = 9000;

        badGuy.name = "Végéta";
        badGuy.lifePoints = 10;
        badGuy.attackForce = 9001;
        badGuy.defenseForce = 9000;

        // mise en scène
    }
}