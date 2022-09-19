using System.Globalization;
namespace calendar_events;

public class Event : IEvent
{

    public string? Title { get; set; }
    public DateTime EventDate { get; set; }
    public string? Description { get; set; }


    public Event(string title, string date, string description)
    {
        Title = title;
        EventDate = Convert.ToDateTime(date);
        Description = description;
    }

    public Event(string title, string date)
    {
        Title = title;
        EventDate = Convert.ToDateTime(date);
    }

    public void DelayDate(int days)
    {
        EventDate = EventDate.AddDays(days);
    }

    public string PrintEvent(string format)
    {
        return $"Evento = {Title}\n Date = {EventDate.ToString(format)}\n Description = {Description}";
    }
}
