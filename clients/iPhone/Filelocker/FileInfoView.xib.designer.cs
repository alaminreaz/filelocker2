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
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("FileInfoView")]
	public partial class FileInfoView {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_btnDelete;
		
		private MonoTouch.UIKit.UITableView __mt_tblFileInfo;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnDelete")]
		private MonoTouch.UIKit.UIBarButtonItem btnDelete {
			get {
				this.__mt_btnDelete = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("btnDelete")));
				return this.__mt_btnDelete;
			}
			set {
				this.__mt_btnDelete = value;
				this.SetNativeField("btnDelete", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("tblFileInfo")]
		private MonoTouch.UIKit.UITableView tblFileInfo {
			get {
				this.__mt_tblFileInfo = ((MonoTouch.UIKit.UITableView)(this.GetNativeField("tblFileInfo")));
				return this.__mt_tblFileInfo;
			}
			set {
				this.__mt_tblFileInfo = value;
				this.SetNativeField("tblFileInfo", value);
			}
		}
	}
}
