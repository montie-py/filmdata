namespace FilmInventory.Business.Entities;

public class Film
{
    private int id;
    private FilmData filmData;
    private Camera camera;
    private string developer;
    private DateOnly dateDeveloped;
    private int timeMinutes;
    private int temperatureCelsius;
}