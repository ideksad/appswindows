// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// DogbreedsLetterE_DogbreedsLetterE interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IDogbreedsLetterE_DogbreedsLetterE
    {
		ObservableCollection<Entities.DogbreedsLetterESchema> GetData(int pageNumber = 0);
		ObservableCollection<Entities.DogbreedsLetterESchema> Search(FilterSpecification filter);
		bool HasPrevious(Entities.DogbreedsLetterESchema current);
		bool HasNext(Entities.DogbreedsLetterESchema current);
		Entities.DogbreedsLetterESchema Previous(Entities.DogbreedsLetterESchema current);
		Entities.DogbreedsLetterESchema Next(Entities.DogbreedsLetterESchema current);
    }
}
