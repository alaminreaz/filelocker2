// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Filelocker {
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[MonoTouch.Foundation.Register("AppDelegate")]
	public partial class AppDelegate {
		
		private MonoTouch.UIKit.UIWindow __mt_window;
		
		private MonoTouch.UIKit.UITabBarController __mt_tabBarController;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("window")]
		private MonoTouch.UIKit.UIWindow window {
			get {
				this.__mt_window = ((MonoTouch.UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("tabBarController")]
		private MonoTouch.UIKit.UITabBarController tabBarController {
			get {
				this.__mt_tabBarController = ((MonoTouch.UIKit.UITabBarController)(this.GetNativeField("tabBarController")));
				return this.__mt_tabBarController;
			}
			set {
				this.__mt_tabBarController = value;
				this.SetNativeField("tabBarController", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("SettingsViewController")]
	public partial class SettingsViewController {
		
		private MonoTouch.UIKit.UITableView __mt_tblLogin;
		
		private MonoTouch.UIKit.UIView __mt_vwMain;
		
		private MonoTouch.UIKit.UIButton __mt_btnVerify;
		
		private MonoTouch.UIKit.UILabel __mt_lblStatus;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("tblLogin")]
		private MonoTouch.UIKit.UITableView tblLogin {
			get {
				this.__mt_tblLogin = ((MonoTouch.UIKit.UITableView)(this.GetNativeField("tblLogin")));
				return this.__mt_tblLogin;
			}
			set {
				this.__mt_tblLogin = value;
				this.SetNativeField("tblLogin", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("vwMain")]
		private MonoTouch.UIKit.UIView vwMain {
			get {
				this.__mt_vwMain = ((MonoTouch.UIKit.UIView)(this.GetNativeField("vwMain")));
				return this.__mt_vwMain;
			}
			set {
				this.__mt_vwMain = value;
				this.SetNativeField("vwMain", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnVerify")]
		private MonoTouch.UIKit.UIButton btnVerify {
			get {
				this.__mt_btnVerify = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnVerify")));
				return this.__mt_btnVerify;
			}
			set {
				this.__mt_btnVerify = value;
				this.SetNativeField("btnVerify", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblStatus")]
		private MonoTouch.UIKit.UILabel lblStatus {
			get {
				this.__mt_lblStatus = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblStatus")));
				return this.__mt_lblStatus;
			}
			set {
				this.__mt_lblStatus = value;
				this.SetNativeField("lblStatus", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("FilesViewController")]
	public partial class FilesViewController {
		
		private MonoTouch.UIKit.UITableView __mt_tblFiles;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_btnUpload;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_btnRefresh;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("tblFiles")]
		private MonoTouch.UIKit.UITableView tblFiles {
			get {
				this.__mt_tblFiles = ((MonoTouch.UIKit.UITableView)(this.GetNativeField("tblFiles")));
				return this.__mt_tblFiles;
			}
			set {
				this.__mt_tblFiles = value;
				this.SetNativeField("tblFiles", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnUpload")]
		private MonoTouch.UIKit.UIBarButtonItem btnUpload {
			get {
				this.__mt_btnUpload = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("btnUpload")));
				return this.__mt_btnUpload;
			}
			set {
				this.__mt_btnUpload = value;
				this.SetNativeField("btnUpload", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnRefresh")]
		private MonoTouch.UIKit.UIBarButtonItem btnRefresh {
			get {
				this.__mt_btnRefresh = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("btnRefresh")));
				return this.__mt_btnRefresh;
			}
			set {
				this.__mt_btnRefresh = value;
				this.SetNativeField("btnRefresh", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MessagesViewController")]
	public partial class MessagesViewController {
		
		private MonoTouch.UIKit.UITableView __mt_tblMessages;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_btnCompose;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_btnRefresh;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("tblMessages")]
		private MonoTouch.UIKit.UITableView tblMessages {
			get {
				this.__mt_tblMessages = ((MonoTouch.UIKit.UITableView)(this.GetNativeField("tblMessages")));
				return this.__mt_tblMessages;
			}
			set {
				this.__mt_tblMessages = value;
				this.SetNativeField("tblMessages", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnCompose")]
		private MonoTouch.UIKit.UIBarButtonItem btnCompose {
			get {
				this.__mt_btnCompose = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("btnCompose")));
				return this.__mt_btnCompose;
			}
			set {
				this.__mt_btnCompose = value;
				this.SetNativeField("btnCompose", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnRefresh")]
		private MonoTouch.UIKit.UIBarButtonItem btnRefresh {
			get {
				this.__mt_btnRefresh = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("btnRefresh")));
				return this.__mt_btnRefresh;
			}
			set {
				this.__mt_btnRefresh = value;
				this.SetNativeField("btnRefresh", value);
			}
		}
	}
}
