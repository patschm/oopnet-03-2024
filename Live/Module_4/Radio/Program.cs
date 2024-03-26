namespace Radio;

class Program
{
    static void Main(string[] args)
    {
        Station veronica = new Station();
        veronica.subscribers += OntvangstMethodes.ViaSMS;
        veronica.subscribers += OntvangstMethodes.ViaPostduif;
        veronica.subscribers += OntvangstMethodes.ViaKabel;
        veronica.subscribers += OntvangstMethodes.ViaRooksignalen;
        veronica.subscribers += OntvangstMethodes.ViaEther;
        veronica.subscribers += OntvangstMethodes.ViaSMS;
        veronica.subscribers += OntvangstMethodes.ViaPostduif;
        veronica.subscribers += OntvangstMethodes.ViaKabel;
        veronica.subscribers += OntvangstMethodes.ViaRooksignalen;
        veronica.subscribers += OntvangstMethodes.ViaEther;
        veronica.subscribers += OntvangstMethodes.ViaSMS;
        

        veronica.Broadcast();

        //veronica.subscribers("Hey klojo's");
    }
}
