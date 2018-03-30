             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ChordRepository : Repository<Chord>, IChordRepository
{

    public ChordRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IChordRepository.cs file
}
