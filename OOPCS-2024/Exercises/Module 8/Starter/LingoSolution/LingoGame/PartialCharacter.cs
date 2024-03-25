namespace LingoGame
{
    public class PartialCharacter : LingoCharacter
    {
       public override void Draw(IDevice device)
        {
            device.DrawPartial(Character);
           
        }
    }
}
