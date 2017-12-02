using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Interface for getting Note;
    /// </summary>
    public interface IProvidable
    {
        /// <summary>
        /// Gets note's value;
        /// </summary>
        /// <returns>Note</returns>
        Note GetNote();
        /// <summary>
        /// Gets notebook's value.
        /// </summary>
        /// <returns>NoteBook</returns>
        NoteBook GetNoteBook();
    }
}
