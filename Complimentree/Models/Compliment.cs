namespace Complimentree.Models
{
    public class Compliment
    {
        public int ComplimentId { get; set; }
        public string Text { get; set; }
        public static int counter = 0;

        public Compliment(int complimentId, string text)
        {
            ComplimentId = complimentId;
            Text = text;
        }

        public static List<Compliment> ComplimentsList = new List<Compliment>()
        {
            new Compliment( 1, "You may not be evergreen, but you are to me." ),
            new Compliment( 2, "I bet squirrels consider you prime real estate." ),
            new Compliment( 3, "You're so down to earth." ),
            new Compliment( 4, "You're very grounded." ),
            new Compliment( 5, "Your leaves are soothing." ),
            new Compliment( 6, "You sway nicely in the wind." ),
            new Compliment( 7, "You're blooming brilliant." ),
            new Compliment( 8, "You're really good at standing still and doing nothing." ),
            new Compliment( 9, "Let's get to the root of your beauty." ),
            new Compliment( 10, "I will never leaf you." ),
            new Compliment( 11, "You've really branched out lately." ),
            new Compliment( 12, "You provide the perfect amount of shade on a hot day." ),
            new Compliment( 13, "I'm really pine-ing for you." )
        };

        public static Compliment GetCompliment()
        {
            Compliment thisCompliment = ComplimentsList[counter];
            counter += 1;
            return thisCompliment;
        }
    }

}
