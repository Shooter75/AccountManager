   M S B A M L   `   `   `  ����I  EAccountManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AccountManagerAccountManager  5      %    AccountManager.UIL.CategoryList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.8.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5      1AccountManagerclr-namespace:AccountManager  5      -   5          � 	Resources  5
      ,   &AccountManager.AccountManagerDBDataSet   accountManagerDBDataSet  categoryViewSource �� Source �� Source��%Y   &	        &	      7     5   
   61   �� 5   
    6:   �� *
Category+8   5      .��5      �   ContentRoot#��[ 6   .+�5   
   �� .��5      �� $	��200��6    � DataContext# [ 6(   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ categoryDataGrid��5   P      
IsReadOnly .    SelectionMode$ Single=�6|   $	��580��6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��291��6�      EnableRowVirtualization . 	   AutoGenerateColumns	 .  ��6�   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idCategoryColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5   G      
IsReadOnly .    Header$ Id Category��6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6{   �� *
IdCategory+  5      -   5        
nameColumn��$
 Auto 5   A   $
 Name��6N    6\   �� *Name+5      �� 5      -   5         ��Name$ Delete_B��5      $��Delete��6/   $��80��6G   $��
-225,0,0,0q�6S   
���  ��$y�Hidden=�6�   �� 5      -   5        $ Update_B��5      $��Update��6/   $��80��6G   $��225,-26,0,0q�6S   
��� ���$y�Hidden=�6�   5      5      5      5      