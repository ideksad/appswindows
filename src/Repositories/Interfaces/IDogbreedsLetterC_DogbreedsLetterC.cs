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
    /// DogbreedsLetterC_DogbreedsLetterC interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IDogbreedsLetterC_DogbreedsLetterC
    {
		ObservableCollection<Entities.DogbreedsLetterCSchema> GetData(int pageNumber = 0);
		ObservableCollection<Entities.DogbreedsLetterCSchema> Search(FilterSpecification filter);
		bool HasPrevious(Entities.DogbreedsLetterCSchema current);
		bool HasNext(Entities.DogbreedsLetterCSchema current);
		Entities.DogbreedsLetterCSchema Previous(Entities.DogbreedsLetterCSchema current);
		Entities.DogbreedsLetterCSchema Next(Entities.DogbreedsLetterCSchema current);
    }
}