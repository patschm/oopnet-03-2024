namespace LingoGame
{
    public class ExactCharacter : LingoCharacter
    {
        public override void Draw(IDevice device)
        {
            device.DrawExact(Character);
           
        }
    }
}
