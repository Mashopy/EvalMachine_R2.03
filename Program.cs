Console.WriteLine("Saisir la taille du tableau:");
int taille = Convert.ToInt32(Console.ReadLine());

int[] T = TableauEntier(taille);
int premier = SaisieEntierPremier();
int second = SaisieEntierSecond();
int[] T2 = TableauResultat(T, premier, second);

static int[] TableauEntier(int taille)
{
    int[] T = new int[taille];

    for (int i = 0; i < T.Length; i++)
    {
        Console.WriteLine($"Saisir l'élément {i}:");
        T[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    return T;
}

static int SaisieEntierPremier()
{
    Console.WriteLine("Saisir l'élément à remplacer:");
    int valeur = Convert.ToInt32(Console.ReadLine());

    return valeur;
}

static int SaisieEntierSecond()
{
    Console.WriteLine("Saisir la valeur avec laquelle le remplacer:");
    int valeur = Convert.ToInt32(Console.ReadLine());

    return valeur;
}

static int[] TableauResultat(int[] tab, int premier, int second)
{
    int[] T2 = tab;

    for (int i = 0; i < T2.Length; i++) {
        if (T2[i] == premier) {
            T2[i] = second;
        }
    }

    return T2;
}
