using UnityEngine;
using System.Collections;


/// <summary>
/// General use exception for the game. Used as a super class for other exceptions.
/// </summary>
public class GwentException : System.Exception
{
  public GwentException() { }
  public GwentException( string message ) : base( message ) { }
  public GwentException( string message, System.Exception inner ) : base( message, inner ) { }
  protected GwentException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}

/// <summary>
/// Exception indicating that a draw operation on a deck was unsuccessfull due to an empty deck.
/// </summary>
public class DeckEmptyException : GwentException
{
  public DeckEmptyException() { }
  public DeckEmptyException( string message ) : base( message ) { }
  public DeckEmptyException( string message, System.Exception inner ) : base( message, inner ) { }
  protected DeckEmptyException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}

/// <summary>
/// Exception raised when a file contains an invalid JSON deck.
/// </summary>
public class DeckLoaderException : GwentException
{
    public DeckLoaderException() { }
    public DeckLoaderException(string message) : base(message) { }
    public DeckLoaderException(string message, System.Exception inner) : base(message, inner) { }
    protected DeckLoaderException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
}