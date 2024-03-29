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
    /// Implementation of DogbreedsLetterB_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class DogbreedsLetterB_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IDogbreedsLetterB_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.DogbreedsLetterB_DogbreedsLetterB _dogbreedsLetterB_DogbreedsLetterB;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="DogbreedsLetterB_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dogbreedsLetterB_DogbreedsLetterB">The Dogbreeds Letter B_ Dogbreeds Letter B.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public DogbreedsLetterB_DetailViewModel(Repositories.DogbreedsLetterB_DogbreedsLetterB dogbreedsLetterB_DogbreedsLetterB, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_dogbreedsLetterB_DogbreedsLetterB = dogbreedsLetterB_DogbreedsLetterB;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.DogbreedsLetterBSchema _currentDogbreedsLetterBSchema;

        /// <summary>
        /// CurrentDogbreedsLetterBSchema property.
        /// </summary>		
        public Entities.DogbreedsLetterBSchema CurrentDogbreedsLetterBSchema
        {
            get
            {
				return _currentDogbreedsLetterBSchema;
            }
            set
            {
                SetProperty(ref _currentDogbreedsLetterBSchema, value);
            }
        }
	
		private bool _hasNextpanoramaDogbreedsLetterB_Detail0;

        /// <summary>
        /// HasNextpanoramaDogbreedsLetterB_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaDogbreedsLetterB_Detail0
        {
            get
            {
				return _hasNextpanoramaDogbreedsLetterB_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaDogbreedsLetterB_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaDogbreedsLetterB_Detail0;

        /// <summary>
        /// HasPreviouspanoramaDogbreedsLetterB_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaDogbreedsLetterB_Detail0
        {
            get
            {
				return _hasPreviouspanoramaDogbreedsLetterB_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaDogbreedsLetterB_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechDogbreedsLetterB_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentDogbreedsLetterBSchema.Subtitle + " " + CurrentDogbreedsLetterBSchema.Description);
        }
		

        private ICommand _textToSpeechDogbreedsLetterB_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechDogbreedsLetterB_DetailStaticControlCommand
        {
            get { return _textToSpeechDogbreedsLetterB_DetailStaticControlCommand = _textToSpeechDogbreedsLetterB_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechDogbreedsLetterB_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareDogbreedsLetterB_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentDogbreedsLetterBSchema.Subtitle, CurrentDogbreedsLetterBSchema.Description, "", CurrentDogbreedsLetterBSchema.Image);
        }
		

        private ICommand _shareDogbreedsLetterB_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareDogbreedsLetterB_DetailStaticControlCommand
        {
            get { return _shareDogbreedsLetterB_DetailStaticControlCommand = _shareDogbreedsLetterB_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareDogbreedsLetterB_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartDogbreedsLetterB_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IDogbreedsLetterB_DetailViewModel), CreateTileInfoDogbreedsLetterB_DetailStaticControl());
        }
		

        private ICommand _pinToStartDogbreedsLetterB_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartDogbreedsLetterB_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartDogbreedsLetterB_DetailStaticControlCommand
        {
            get { return _pinToStartDogbreedsLetterB_DetailStaticControlCommand = _pinToStartDogbreedsLetterB_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartDogbreedsLetterB_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaDogbreedsLetterB_Detail0 command.
        /// </summary>
        public  void NextpanoramaDogbreedsLetterB_Detail0Delegate() 
        {
			var next =  _dogbreedsLetterB_DogbreedsLetterB.Next(CurrentDogbreedsLetterBSchema);

			if(next != null)
				CurrentDogbreedsLetterBSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramaDogbreedsLetterB_Detail0;

        /// <summary>
        /// Gets the NextpanoramaDogbreedsLetterB_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaDogbreedsLetterB_Detail0
        {
            get { return _nextpanoramaDogbreedsLetterB_Detail0 = _nextpanoramaDogbreedsLetterB_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaDogbreedsLetterB_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaDogbreedsLetterB_Detail0 command.
        /// </summary>
        public  void PreviouspanoramaDogbreedsLetterB_Detail0Delegate() 
        {
			var prev =  _dogbreedsLetterB_DogbreedsLetterB.Previous(CurrentDogbreedsLetterBSchema);

			if(prev != null)
				CurrentDogbreedsLetterBSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaDogbreedsLetterB_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaDogbreedsLetterB_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaDogbreedsLetterB_Detail0
        {
            get { return _previouspanoramaDogbreedsLetterB_Detail0 = _previouspanoramaDogbreedsLetterB_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaDogbreedsLetterB_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramaDogbreedsLetterB_Detail0 = _dogbreedsLetterB_DogbreedsLetterB.HasPrevious(CurrentDogbreedsLetterBSchema);
			HasNextpanoramaDogbreedsLetterB_Detail0 = _dogbreedsLetterB_DogbreedsLetterB.HasNext(CurrentDogbreedsLetterBSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.DogbreedsLetterBSchema)) { return; }
                
                CurrentDogbreedsLetterBSchema = value as Entities.DogbreedsLetterBSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the DogbreedsLetterB_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoDogbreedsLetterB_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentDogbreedsLetterBSchema.Id.ToString(),
                Title = CurrentDogbreedsLetterBSchema.Subtitle,
                BackTitle = CurrentDogbreedsLetterBSchema.Subtitle,
                BackContent = CurrentDogbreedsLetterBSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentDogbreedsLetterBSchema.Image,
                BackBackgroundImagePath = CurrentDogbreedsLetterBSchema.Image,
                LogoPath = "Item-46655a22-e9de-4ba1-8c70-bb036184cb54.png"
            };
            return tileInfo;
        }
    }
}
