   M S B A M L   `   `   `  ����O  KRepairShopAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RepairShopAccountingRepairShopAccounting  5   	   %    RepairShopAccounting.ViewOrders   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:RepairShopAccounting     5   	     � Title$6  0Посмотреть список заказов��5   	   $	��800��6+   $
��1500��68    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   �� -   5         ��Name$ ViewAllOrdersButton��5      $.��(Посмотреть все заказы��6.   $
��Left=�6N   $��
252,46,0,0q�6i   $	��Top=�6}   $	��136��6�   $��33��6�   6�   �� 5   
   -   5        $ ViewCurrentOrdersButton��5      $6��0Посмотреть текущие заказы��62   $
��Left=�6V   $��
639,46,0,0q�6q   $	��Top=�6�   $	��163��6�   $��33��6�   6�   �� 5   
   -   5        $ ViewCompletedOrdersButton��5      $>��8Посмотреть выполненные заказы��64   $
��Left=�6\   $��1052,46,0,0q�6w   $	��Top=�6�   $	��194��6�   $��33��6�   6�   �� 5   
   -   5         ��Name$ Table��5      $
��Left=�6"   $	��603��6=   $	��Top=�6J   $
��1346��6b   $��
64,106,0,0q�6o    �� View 5      �� 5      .P�5      ��  �� Width$	 100��6Y    �� DisplayMemberBinding 6%   ��  �� Path$ OrderNumber�.��6e   Номер заказа6s   �� 5      $	 100��6X    6%   �� $ 
NameClient�.��6d   ФИО Клиента6q   �� 5      $	 100��6]    6%   �� $ DateOfReceiving�.��6i   Дата получения6y   �� 5      $	 105��6Y    6%   �� $ DateOfIssue�.��6e   Дата выдачи6r   �� 5      $	 130��6]    6%   �� $ EquipmentNumber�.��6i   %#Номер оборудования6}   �� 5      $	 700��6V    6%   �� $ services�.��6b   Услуги6j   �� 5      $	 100��6S    6%   �� $ Price�.��6_   Сумма заказа6m   5      5      5      5      