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
    /// DogbreedsLetterE_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IDogbreedsLetterE_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentDogbreedsLetterESchema property.
        /// </summary>
		Entities.DogbreedsLetterESchema CurrentDogbreedsLetterESchema { get; set; }
        /// <summary>
        /// Gets/Sets the HasNextpanoramaDogbreedsLetterE_Detail0 property.
        /// </summary>
		bool HasNextpanoramaDogbreedsLetterE_Detail0 { get; set; }
        /// <summary>
        /// Gets/Sets the HasPreviouspanoramaDogbreedsLetterE_Detail0 property.
        /// </summary>
		bool HasPreviouspanoramaDogbreedsLetterE_Detail0 { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechDogbreedsLetterE_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
		ICommand ShareDogbreedsLetterE_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartDogbreedsLetterE_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartDogbreedsLetterE_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the NextpanoramaDogbreedsLetterE_Detail0 command.
        /// </summary>
		ICommand NextpanoramaDogbreedsLetterE_Detail0 { get; }

        
        /// <summary>
        /// Gets the PreviouspanoramaDogbreedsLetterE_Detail0 command.
        /// </summary>
		ICommand PreviouspanoramaDogbreedsLetterE_Detail0 { get; }

	}
}
