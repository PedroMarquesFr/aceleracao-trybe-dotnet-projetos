namespace election_day
{
    public class BallotBox
    {
        public int receivedOption1 = 0;
        public int receivedOption2 = 0;
        public int receivedOption3 = 0;
        public int optionNull = 0;


        public int GetCountVoters()
        {
            bool isValid = false;
            int electorsNumber;
            do
            {
                Console.WriteLine("Insira o numero de eleitores:");
                var input = Console.ReadLine();
                isValid = int.TryParse(input, out electorsNumber);
            } while (!isValid);
            if (electorsNumber <= 0) return 1;
            return electorsNumber;
        }

        public void Start(int countVoters)
        {
            for (int elector = 0; elector >= countVoters; elector++)
            {
                Console.WriteLine("Digite o número do candidato de 1 a 3:");
                var option = Console.ReadLine();
                if (!Int32.TryParse(option, out int vote)) continue;
                switch (option)
                {
                    case "1":
                        receivedOption1 += 1;
                        break;
                    case "2":
                        receivedOption2 += 1;
                        break;
                    case "3":
                        receivedOption3 += 1;
                        break;
                    default:
                        optionNull += 1;
                        break;
                }
            }
            Console.WriteLine("Votação finalizada!!!!");
        }

        public void PrintResult()
        {
            Console.WriteLine($"A opção 1 recebeu: {receivedOption1} voto(s)");
            Console.WriteLine($"A opção 2 recebeu: {receivedOption2} voto(s)");
            Console.WriteLine($"A opção 3 recebeu: {receivedOption3} voto(s)");
            Console.WriteLine($"Total de votos anulados: {optionNull} voto(s)");
        }
    }
}
