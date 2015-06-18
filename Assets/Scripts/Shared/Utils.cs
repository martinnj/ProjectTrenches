using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


/// <summary>
/// Utility class containing functions that don't need to belong in any specific class.
/// </summary>
public static class Utils
{
    /// <summary>
    /// Use the Fisher-Yates shuffle to shuffle a list.
    /// Code from: http://stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp
    /// </summary>
    /// <typeparam name="T">Type the list elements.</typeparam>
    /// <param name="list">List to shuffle.</param>
    public static void Shuffle<T>(this IList<T> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    /// <summary>
    /// Parses a .deck file into a Deck object.
    /// </summary>
    /// <param name="filePath">Path to the filename with the deck in it.</param>
    /// <returns>Returns a deck representing the data from the file.</returns>
    public static Deck LoadDeck(string filePath)
    {
        try
        {
            Deck deck;
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                deck = (Deck) formatter.Deserialize(fs);
                fs.Close();

            }
            return deck;
        }
        catch (Exception ex)
        {
            throw new DeckLoaderException("The deck could not be loaded: " + ex.Message, ex);
        }
    }

    /// <summary>
    /// Saves a deck as a .deck file.
    /// </summary>
    /// <param name="filePath">String indicating where to save the deck.</param>
    /// <param name="deck">The deck to serialize and save.</param>
    public static void SaveDeck(string filePath, Deck deck)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, deck);
                fs.Close();
            }
        }
        catch (Exception ex)
        {
            throw new GwentException("Error occured when trying to save deck: " + ex.Message, ex);
        }
    }
}
