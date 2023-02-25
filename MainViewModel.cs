using AudioFileLoader.Services;

namespace AudioFileLoader.ViewModel;
public class MainViewModel
{
	IAudioFileLoaderService audioFileLoaderService;
	public MainViewModel(IAudioFileLoaderService audioFileLoaderService)
	{
		this.audioFileLoaderService = audioFileLoaderService;
		// write the datatyep of the service to the console
		Console.WriteLine(audioFileLoaderService.GetType());
	}
}