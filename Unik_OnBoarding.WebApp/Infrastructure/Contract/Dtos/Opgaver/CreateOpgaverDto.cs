using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;

public class CreateOpgaverDto
{
	public string OpgaveName { get; set; }
	public string Beskrivelse { get; set; }
}