// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of DogbreedsLetterD_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class DogbreedsLetterD_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IDogbreedsLetterD_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.DogbreedsLetterD_DogbreedsLetterD _dogbreedsLetterD_DogbreedsLetterD;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="DogbreedsLetterD_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dogbreedsLetterD_DogbreedsLetterD">The Dogbreeds Letter D_ Dogbreeds Letter D.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public DogbreedsLetterD_DetailViewModel(Repositories.DogbreedsLetterD_DogbreedsLetterD dogbreedsLetterD_DogbreedsLetterD, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_dogbreedsLetterD_DogbreedsLetterD = dogbreedsLetterD_DogbreedsLetterD;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.DogbreedsLetterDSchema _currentDogbreedsLetterDSchema;

        /// <summary>
        /// CurrentDogbreedsLetterDSchema property.
        /// </summary>		
        public Entities.DogbreedsLetterDSchema CurrentDogbreedsLetterDSchema
        {
            get
            {
				return _currentDogbreedsLetterDSchema;
            }
            set
            {
                SetProperty(ref _currentDogbreedsLetterDSchema, value);
            }
        }
	
		private bool _hasNextpanoramaDogbreedsLetterD_Detail0;

        /// <summary>
        /// HasNextpanoramaDogbreedsLetterD_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaDogbreedsLetterD_Detail0
        {
            get
            {
				return _hasNextpanoramaDogbreedsLetterD_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaDogbreedsLetterD_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaDogbreedsLetterD_Detail0;

        /// <summary>
        /// HasPreviouspanoramaDogbreedsLetterD_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaDogbreedsLetterD_Detail0
        {
            get
            {
				return _hasPreviouspanoramaDogbreedsLetterD_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaDogbreedsLetterD_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechDogbreedsLetterD_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechDogbreedsLetterD_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentDogbreedsLetterDSchema.Subtitle + " " + CurrentDogbreedsLetterDSchema.Description);
        }
		

        private ICommand _textToSpeechDogbreedsLetterD_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechDogbreedsLetterD_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechDogbreedsLetterD_DetailStaticControlCommand
        {
            get { return _textToSpeechDogbreedsLetterD_DetailStaticControlCommand = _textToSpeechDogbreedsLetterD_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechDogbreedsLetterD_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareDogbreedsLetterD_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareDogbreedsLetterD_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentDogbreedsLetterDSchema.Subtitle, CurrentDogbreedsLetterDSchema.Description, "", CurrentDogbreedsLetterDSchema.Image);
        }
		

        private ICommand _shareDogbreedsLetterD_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareDogbreedsLetterD_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareDogbreedsLetterD_DetailStaticControlCommand
        {
            get { return _shareDogbreedsLetterD_DetailStaticControlCommand = _shareDogbreedsLetterD_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareDogbreedsLetterD_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartDogbreedsLetterD_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartDogbreedsLetterD_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IDogbreedsLetterD_DetailViewModel), CreateTileInfoDogbreedsLetterD_DetailStaticControl());
        }
		

        private ICommand _pinToStartDogbreedsLetterD_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartDogbreedsLetterD_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartDogbreedsLetterD_DetailStaticControlCommand
        {
            get { return _pinToStartDogbreedsLetterD_DetailStaticControlCommand = _pinToStartDogbreedsLetterD_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartDogbreedsLetterD_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaDogbreedsLetterD_Detail0 command.
        /// </summary>
        public  void NextpanoramaDogbreedsLetterD_Detail0Delegate() 
        {
			var next =  _dogbreedsLetterD_DogbreedsLetterD.Next(CurrentDogbreedsLetterDSchema);

			if(next != null)
				CurrentDogbreedsLetterDSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramaDogbreedsLetterD_Detail0;

        /// <summary>
        /// Gets the NextpanoramaDogbreedsLetterD_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaDogbreedsLetterD_Detail0
        {
            get { return _nextpanoramaDogbreedsLetterD_Detail0 = _nextpanoramaDogbreedsLetterD_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaDogbreedsLetterD_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaDogbreedsLetterD_Detail0 command.
        /// </summary>
        public  void PreviouspanoramaDogbreedsLetterD_Detail0Delegate() 
        {
			var prev =  _dogbreedsLetterD_DogbreedsLetterD.Previous(CurrentDogbreedsLetterDSchema);

			if(prev != null)
				CurrentDogbreedsLetterDSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaDogbreedsLetterD_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaDogbreedsLetterD_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaDogbreedsLetterD_Detail0
        {
            get { return _previouspanoramaDogbreedsLetterD_Detail0 = _previouspanoramaDogbreedsLetterD_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaDogbreedsLetterD_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramaDogbreedsLetterD_Detail0 = _dogbreedsLetterD_DogbreedsLetterD.HasPrevious(CurrentDogbreedsLetterDSchema);
			HasNextpanoramaDogbreedsLetterD_Detail0 = _dogbreedsLetterD_DogbreedsLetterD.HasNext(CurrentDogbreedsLetterDSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.DogbreedsLetterDSchema)) { return; }
                
                CurrentDogbreedsLetterDSchema = value as Entities.DogbreedsLetterDSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the DogbreedsLetterD_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoDogbreedsLetterD_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentDogbreedsLetterDSchema.Id.ToString(),
                Title = CurrentDogbreedsLetterDSchema.Subtitle,
                BackTitle = CurrentDogbreedsLetterDSchema.Subtitle,
                BackContent = CurrentDogbreedsLetterDSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentDogbreedsLetterDSchema.Image,
                BackBackgroundImagePath = CurrentDogbreedsLetterDSchema.Image,
                LogoPath = "Item-46655a22-e9de-4ba1-8c70-bb036184cb54.png"
            };
            return tileInfo;
        }
    }
}
