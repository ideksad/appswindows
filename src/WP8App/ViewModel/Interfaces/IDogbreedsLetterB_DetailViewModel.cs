// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// DogbreedsLetterB_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IDogbreedsLetterB_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentDogbreedsLetterBSchema property.
        /// </summary>
		Entities.DogbreedsLetterBSchema CurrentDogbreedsLetterBSchema { get; set; }
        /// <summary>
        /// Gets/Sets the HasNextpanoramaDogbreedsLetterB_Detail0 property.
        /// </summary>
		bool HasNextpanoramaDogbreedsLetterB_Detail0 { get; set; }
        /// <summary>
        /// Gets/Sets the HasPreviouspanoramaDogbreedsLetterB_Detail0 property.
        /// </summary>
		bool HasPreviouspanoramaDogbreedsLetterB_Detail0 { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechDogbreedsLetterB_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
		ICommand ShareDogbreedsLetterB_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartDogbreedsLetterB_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the NextpanoramaDogbreedsLetterB_Detail0 command.
        /// </summary>
		ICommand NextpanoramaDogbreedsLetterB_Detail0 { get; }

        
        /// <summary>
        /// Gets the PreviouspanoramaDogbreedsLetterB_Detail0 command.
        /// </summary>
		ICommand PreviouspanoramaDogbreedsLetterB_Detail0 { get; }

	}
}
