using System.Globalization;
namespace DataHandler;

public class Schedule : IScheduleFormat
{
    public DateTime[] nextEvents { get; }

    public Schedule()
    {
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);
        nextEvents = new DateTime[10];
    }

    public string NextEvent()
    {
        if (nextEvents[0] == new DateTime()) return "Não há eventos marcados";
        else return nextEvents[0].ToString("D");
    }

    public void AddEventAtDays(int days)
    {
        for (int index = 0; index < nextEvents.Length - 1; index++)
        {
            if (nextEvents[index] == new DateTime())
            {
                nextEvents[index] = (DateTime.Now).AddDays(days);
                return;
            }
        }
        throw new ArgumentException("Não há espaço disponível para o evento.");
    }

    public void RemoveFirstEvent()
    {
        for (int index = 0; index < nextEvents.Length - 1; index++)
        {
            if (nextEvents[index] == new DateTime() || index == nextEvents.Length - 1)
            {
                nextEvents[index] = new DateTime();
                return;
            }
            nextEvents[index] = nextEvents[index + 1];
        }
    }

}
