using System;
using Notepad.CommandExceptions;
using Notepad.Commands;

namespace Notepad.CommandBuilders
{
  /// <summary>
  /// Class-builder for Create Command
  /// Realizes pattern Chain of responsibility
  /// </summary>
  public class CreateCommandBuilder : CommandBuilder
  {
    /// <summary>
    /// Set successor in chain
    /// </summary>
    /// <param name="successor">successor</param>
    public CreateCommandBuilder(CommandBuilder successor)
    {
      this.successor = successor;
    }

    /// <summary>
    /// If can build command with such params
    /// returns new Create command
    /// Else calls successor and try build command in successor
    /// Throws if cannot return command
    /// </summary>
    /// <param name="provider">provider</param>
    /// <param name="args">args</param>
    /// <returns>Create Command</returns>
    public override Command Build(NoteBookProvider provider, string args)
    {
      try
      {
        return new CreateCommand(provider, args);
      }
      catch (CommandTypeException)
      {
        if (successor != null)
        {
          return successor.Build(provider, args);
        }
        throw new ArgumentException();
      }
    }
  }
}
