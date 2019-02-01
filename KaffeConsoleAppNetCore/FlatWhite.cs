using kaffe;

namespace KaffeConsoleAppNetCore
{
    public class FlatWhite : Kaffe, Imælk
    {
        public override int Pris()
        {
            return 45;
        }

        public int MlMælk()
        {
            return 160;
        }

        public override string Styrke()
        {
            return "Mild";
        }

        public FlatWhite(int rabat) 
            :base(rabat)
        {
        }
    }
}