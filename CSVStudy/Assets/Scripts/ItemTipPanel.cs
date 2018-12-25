//this file is auto created by QuickCode,you can edit it 
//do not need to care initialization of ui widget any more 
//------------------------------------------------------------------------------
/**
* @author :
* date    :
* purpose :
*/
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemTipPanel : UIWindowBase
{

	#region UI Variable Statement 
	[SerializeField] private Image image_ItemTipPanel; 
	[SerializeField] private Text text_TitleTextPre; 
	[SerializeField] private Text text_PropTextPre; 
	[SerializeField] private Image image_TipItem; 
	[SerializeField] private Button button_TipItem; 
	[SerializeField] private Image image_WhiteImg; 
	[SerializeField] private Image image_BlueImg; 
	[SerializeField] private Image image_PurpleImg; 
	[SerializeField] private Image image_GreenImg; 
	[SerializeField] private Image image_PinkImg; 
	[SerializeField] private Image image_OrangeIMg; 
	[SerializeField] private Image image_DELButton; 
	[SerializeField] private Button button_DELButton; 
	[SerializeField] private Text text_Text; 
	[SerializeField] private Image image_ADDBtn; 
	[SerializeField] private Button button_ADDBtn; 
	[SerializeField] private Text text_Text17; 
	[SerializeField] private Image image_Icon; 
	[SerializeField] private Text text_NameText; 
	[SerializeField] private Shadow shadow_NameText; 
	[SerializeField] private ContentSizeFitter contentsizefitter_NameText; 
	[SerializeField] private Text text_LimitText; 
	[SerializeField] private Shadow shadow_LimitText; 
	[SerializeField] private Text text_TypeName; 
	[SerializeField] private Shadow shadow_TypeName; 
	[SerializeField] private Image image_Weapon; 
	[SerializeField] private Image image_Prp; 
	[SerializeField] private Image image_Mat; 
	[SerializeField] private Text text_NumText; 
	[SerializeField] private Shadow shadow_NumText; 
	[SerializeField] private ScrollRect scrollrect_Scroll_View; 
	[SerializeField] private Image image_Scroll_View; 
	[SerializeField] private Mask mask_Viewport; 
	[SerializeField] private Image image_Viewport; 
	[SerializeField] private ContentSizeFitter contentsizefitter_Content; 
	[SerializeField] private VerticalLayoutGroup verticallayoutgroup_Content; 
	[SerializeField] private Text text_PropTextPre_(1); 
	[SerializeField] private Text text_PropTextPre_(2); 
	[SerializeField] private Text text_PropTextPre_(3); 
	[SerializeField] private Text text_PropTextPre_(4); 
	[SerializeField] private Text text_PropTextPre_(5); 
	[SerializeField] private Text text_PropTextPre_(6); 
	[SerializeField] private Text text_PropTextPre_(7); 
	[SerializeField] private Text text_PropTextPre_(8); 
	[SerializeField] private Text text_PropTextPre_(9); 
	[SerializeField] private Text text_PropTextPre_(10); 
	[SerializeField] private Image image_Image; 
	#endregion 

	#region UI Variable Assignment 
	private void InitUI() 
	{
		image_ItemTipPanel = transform.GetComponent<Image>(); 
		text_TitleTextPre = transform.Find("TitleTextPre").GetComponent<Text>(); 
		text_PropTextPre = transform.Find("PropTextPre").GetComponent<Text>(); 
		image_TipItem = transform.Find("Head/TipItem").GetComponent<Image>(); 
		button_TipItem = transform.Find("Head/TipItem").GetComponent<Button>(); 
		image_WhiteImg = transform.Find("Head/TipItem/RimImgs/WhiteImg").GetComponent<Image>(); 
		image_BlueImg = transform.Find("Head/TipItem/RimImgs/BlueImg").GetComponent<Image>(); 
		image_PurpleImg = transform.Find("Head/TipItem/RimImgs/PurpleImg").GetComponent<Image>(); 
		image_GreenImg = transform.Find("Head/TipItem/RimImgs/GreenImg").GetComponent<Image>(); 
		image_PinkImg = transform.Find("Head/TipItem/RimImgs/PinkImg").GetComponent<Image>(); 
		image_OrangeIMg = transform.Find("Head/TipItem/RimImgs/OrangeIMg").GetComponent<Image>(); 
		image_DELButton = transform.Find("Head/TipItem/RimImgs/DELButton").GetComponent<Image>(); 
		button_DELButton = transform.Find("Head/TipItem/RimImgs/DELButton").GetComponent<Button>(); 
		text_Text = transform.Find("Head/TipItem/RimImgs/DELButton/Text").GetComponent<Text>(); 
		image_ADDBtn = transform.Find("Head/TipItem/RimImgs/ADDBtn").GetComponent<Image>(); 
		button_ADDBtn = transform.Find("Head/TipItem/RimImgs/ADDBtn").GetComponent<Button>(); 
		text_Text17 = transform.Find("Head/TipItem/RimImgs/ADDBtn/Text").GetComponent<Text>(); 
		image_Icon = transform.Find("Head/TipItem/Icon").GetComponent<Image>(); 
		text_NameText = transform.Find("Head/TipItem/NameText").GetComponent<Text>(); 
		shadow_NameText = transform.Find("Head/TipItem/NameText").GetComponent<Shadow>(); 
		contentsizefitter_NameText = transform.Find("Head/TipItem/NameText").GetComponent<ContentSizeFitter>(); 
		text_LimitText = transform.Find("Head/TipItem/LimitText").GetComponent<Text>(); 
		shadow_LimitText = transform.Find("Head/TipItem/LimitText").GetComponent<Shadow>(); 
		text_TypeName = transform.Find("Head/TipItem/TypeName").GetComponent<Text>(); 
		shadow_TypeName = transform.Find("Head/TipItem/TypeName").GetComponent<Shadow>(); 
		image_Weapon = transform.Find("Head/TipItem/TypeImg/Weapon").GetComponent<Image>(); 
		image_Prp = transform.Find("Head/TipItem/TypeImg/Prp").GetComponent<Image>(); 
		image_Mat = transform.Find("Head/TipItem/TypeImg/Mat").GetComponent<Image>(); 
		text_NumText = transform.Find("Head/TipItem/NumText").GetComponent<Text>(); 
		shadow_NumText = transform.Find("Head/TipItem/NumText").GetComponent<Shadow>(); 
		scrollrect_Scroll_View = transform.Find("Scroll View").GetComponent<ScrollRect>(); 
		image_Scroll_View = transform.Find("Scroll View").GetComponent<Image>(); 
		mask_Viewport = transform.Find("Scroll View/Viewport").GetComponent<Mask>(); 
		image_Viewport = transform.Find("Scroll View/Viewport").GetComponent<Image>(); 
		contentsizefitter_Content = transform.Find("Scroll View/Viewport/Content").GetComponent<ContentSizeFitter>(); 
		verticallayoutgroup_Content = transform.Find("Scroll View/Viewport/Content").GetComponent<VerticalLayoutGroup>(); 
		text_PropTextPre_(1) = transform.Find("Scroll View/Viewport/Content/PropTextPre (1)").GetComponent<Text>(); 
		text_PropTextPre_(2) = transform.Find("Scroll View/Viewport/Content/PropTextPre (2)").GetComponent<Text>(); 
		text_PropTextPre_(3) = transform.Find("Scroll View/Viewport/Content/PropTextPre (3)").GetComponent<Text>(); 
		text_PropTextPre_(4) = transform.Find("Scroll View/Viewport/Content/PropTextPre (4)").GetComponent<Text>(); 
		text_PropTextPre_(5) = transform.Find("Scroll View/Viewport/Content/PropTextPre (5)").GetComponent<Text>(); 
		text_PropTextPre_(6) = transform.Find("Scroll View/Viewport/Content/PropTextPre (6)").GetComponent<Text>(); 
		text_PropTextPre_(7) = transform.Find("Scroll View/Viewport/Content/PropTextPre (7)").GetComponent<Text>(); 
		text_PropTextPre_(8) = transform.Find("Scroll View/Viewport/Content/PropTextPre (8)").GetComponent<Text>(); 
		text_PropTextPre_(9) = transform.Find("Scroll View/Viewport/Content/PropTextPre (9)").GetComponent<Text>(); 
		text_PropTextPre_(10) = transform.Find("Scroll View/Viewport/Content/PropTextPre (10)").GetComponent<Text>(); 
		image_Image = transform.Find("Scroll View/Viewport/Content/Image").GetComponent<Image>(); 

	}
	#endregion 

	#region UI Event Register 
	private void AddEvent() 
	{
		button_TipItem.onClick.AddListener(OnTipItemClicked);
		button_DELButton.onClick.AddListener(OnDELButtonClicked);
		button_ADDBtn.onClick.AddListener(OnADDBtnClicked);
		scrollrect_Scroll_View.onValueChanged.AddListener(OnScroll_ViewValueChanged);
	}
 
 
 

	private void OnTipItemClicked()
	{

	}

	private void OnDELButtonClicked()
	{

	}

	private void OnADDBtnClicked()
	{

	}

	private void OnScroll_ViewValueChanged(Vector2 arg)
	{

	}
	#endregion 

	#region UI Base Override Method 
	public override  void OnOpen() 
	{

	}
	public override  void OnClose() 
	{

	}
	public override  void OnHide() 
	{

	}
	public override  void OnShow() 
	{

	}
	public override  void OnRefresh() 
	{

	}
	public override IEnumerator EnterAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack,params object[] objs) 
	{
	    yield break;
	}
	public override IEnumerator ExitAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack,params object[] objs) 
	{
	    yield break;
	}
	#endregion 

}
