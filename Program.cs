// See https://aka.ms/new-console-template for more information
using AudioFileLoader.Services;
using AudioFileLoader.ViewModel;

using Microsoft.Extensions.DependencyInjection;

namespace AudioFileLoader;
internal class Program
{
	
	public static void Main(string[] args)
	{
		var useWeirdAudioFileLoader = true;
		var serviceCollection = new ServiceCollection();

		serviceCollection.AddSingleton<IAudioFileLoaderService, AudioFileLoaderService>();
		if (useWeirdAudioFileLoader)
		{
			serviceCollection.AddSingleton<IAudioFileLoaderService, WeirdAudioFileLoader>();
		}
		else
		{
			serviceCollection.AddSingleton<IAudioFileLoaderService, AudioFileLoaderService>();
		}

		var serviceProvider = serviceCollection.BuildServiceProvider();
		var app = ActivatorUtilities.CreateInstance(serviceProvider, typeof(MainViewModel));
		// MainViewModel mainViewModel = new MainViewModel(new AudioFileLoaderService());
		// Console.WriteLine("Hello, World!");
	}
}