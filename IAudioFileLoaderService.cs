namespace AudioFileLoader.Services
{
	public interface IAudioFileLoaderService
	{
		Task LoadAudioFileAsync(string filePath);
	}
}