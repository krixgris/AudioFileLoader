namespace AudioFileLoader.Services;
public class WeirdAudioFileLoader: IAudioFileLoaderService
{
	public WeirdAudioFileLoader()
	{
		Console.WriteLine("Constructor of WeirdAudioFileLoader");
	}
	public Task LoadAudioFileAsync(string filePath)
	{
		throw new NotImplementedException();
	}
}