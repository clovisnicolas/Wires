﻿using System;

using Foundation;
using UIKit;

namespace Wires.Sample.iOS
{
	public partial class PostCollectionHeader : UICollectionReusableView
	{
		public static readonly NSString Key = new NSString("PostCollectionHeader");

		public static readonly UINib Nib;

		static PostCollectionHeader()
		{
			Nib = UINib.FromName("PostCollectionHeader", NSBundle.MainBundle);
		}

		protected PostCollectionHeader(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
	}
}
