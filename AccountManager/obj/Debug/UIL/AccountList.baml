   M S B A M L   `   `   `  ����  AccountManager$    AccountManager.UIL.AccountList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.8.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5      .��5	      �    ContentRoot#��[  6   .+�5
   
   �� .��5      �� $	��200��6   .+�5      &   System.Windows.Controls.DataGrid  -   5           Name$  accountsDataGrid��5         SelectionMode$ Single=�65      
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $	��455��6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $
��1108��6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idAccountColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
Id Account��5   i      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6�   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6I   �� *	IdAccount+6�     5      -   5        idUserColumn��$ 	User Name��5   i   $
 Auto 6�   	 6I   �� *
UserName+6�     5      -   5        loginColumn��$ Login��5   i   $
 Auto 6�   	 6I   �� *Login+6�     5      -   5        passwordColumn��$ Password��5   i   $
 Auto 6�   	 6I   �� *
Password+6�     5      -   5        domainColumn��$ Domain��5   i   $
 Auto 6�   	 6I   �� *Domain+6�     5      -   5        idCategoryColumn��$ Category��5   i   $
 Auto 6�   	 6I   �� *
Category+6�     5      -   5        siteNameColumn��$ 	Site Name��5   i   $
 Auto 6�   	 6I   �� *
SiteName+6�     5      -	   5        descriptionColumn��$ Description��5   i   $
 Auto 6�   	 6I   �� *Description+6�   5      �� 5      -
   5        
 ��Name$
 Delete_B��5      $��Delete��6/   $��80��6G   $��
-225,0,0,0q�6S   
���  ��$y�Hidden=�6�   �� 5      -   5        $
 Update_B��5      $��Update��6/   $��80��6G   $��225,-26,0,0q�6S   
��� ���$y�Hidden=�6�   �� 5      -   5        $
 RemovHash_B��5      $��Remove Hash��6/   $	��130��6G   $��	0,-27,0,0q�6S   
��� � �$y�Visible=�6�   5      5      5      5      