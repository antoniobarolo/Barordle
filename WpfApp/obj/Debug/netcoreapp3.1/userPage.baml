   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5          WpfApp.userPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:WpfApp     5        N� Title$  userPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ 	userGreet��5      $��Olá, usuário.��6#   $
��Left=�6;   $	��Top=�6V   $��66��6n   $	��223��6z   $��36(�6�   $��0,0                ,0,0q�6�   $��Center=�5      �� 5   
   -   5        $ 
pointLabel��5      $��0 pontos��6$   $
��Left=�67   $	��Top=�6R   $��50��6j   $	��140��6v   $��18(�6�   $��Center=�6�   $��Center=�6�   $��
260,10,0,0q�6�   �� 5   
   -   5        $ wordlistTitle��5      $��Suas Palavras:��6'   $
��Left=�6@   $��
164,66,0,0q�6[   $	��Top=�6o   $��50��6�   $	��500��6�   $��22(�6�   $
��Bold"�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ newWordButton��5      $��+��6(   $
��Left=�64   $��508,116,0,0q�6O   $	��Top=�6d   $��18(�6|   $��34��6�   $��34��6�   6�   �� 5   
   -   5         ��Name$ newWordText��5      $��Center=�6'   $��34��6D   $��	0,116,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��184��6�   $��24(�6�    �� 	MaxLength$ 5��6�    �� TextAlignment$ Center=�6
  �� 5   
   -   5        $ leaderboardTitle��5      $��Leaderboard��6*   $
��Left=�6@   $��	30,71,0,0q�6[   $	��Top=�6n   $��29��6�   $	��225��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ toGameScreen��5      $��Tela de Jogo ->��6'   $
��Left=�6D   $��
694,10,0,0q�6_   $	��Top=�6s   $��34��6�   $��96��6�    �� 	IsDefault$
 True��6�   �� 5   
   -   5        $ signOut1��5      $
��Sair��6#   $
��Left=�62   $��694,427,0,0q�6M   $	��Top=�6b   $��34��6z   $��96��6�   6�   �� 5   
   -	   5        $ percentageLabel��5      $��0% de vitória��6)   $
��Left=�6A   $	��Top=�6\   $��50��6t   $	��140��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $��
419,10,0,0q�6�      WpfApp.WordListComponent  5   
      WpfApp.WordListComponent   Loaded$  WordListComponent_Loaded_1��6:   $��319,180,281,0q�6^   	   Words	 6"   �� *Words+6^   !   WpfApp.LeaderboardComponent  5   
   !   WpfApp.LeaderboardComponent
   Loaded$#
 LeaderboardComponent_Loaded_1��6%   $��18,116,506,10q�6L   5      5      