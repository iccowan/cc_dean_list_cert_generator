   M S B A M L   `   `   `  ���� R  Ngenerate_dean_list_cert, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:generate_dean_list_certgenerate_dean_list_cert  (    "generate_dean_list_cert.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:generate_dean_list_cert       � Title$6  0Generate Dean's List Certificates Centre College��$	��450��$	��800��.��� -    �Name$ MainView��.+��� $
��Left=�$
��Wrap=�$	��Top=�$��	10,10,0,0q�$	��165��$	��536���� $��18(�$'�!Generate Dean's List Certificates���� �� $���Below, select the template certificate using the following keywords for replacement, the input CSV file that includes each student's first name and last name, and the location to output the certificates.���� �� �� �� $C�=In the template file, use the follow keywords to be replaced:���� �� $�#FNAME# - First Name���� �� $�#LNAME# - Last Name���� �� $'�!#YEAR# - Year (as inputted below)���� �� $7�1#TERM# - Term (Fall or Spring, as inputted below)���� -    ��Name$ TemplateCertificate��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$��Template Certificate��$	��Top=�$	��536��$��
10,207,0,0q�
����������	#FFD1DAE5�� -   $ InputStudentFile��$
��Left=�$��23��$
 Wrap=�$��Input Student File (CSV)��$	��Top=�$	��536��$��
10,235,0,0q����	#FFD1DAE5�� -   $ OutputLocation��$
��Left=�$��23��$
 Wrap=�$��Output Location��$	��Top=�$	��536��$��
10,263,0,0q����	#FFD1DAE5�� -   $
 Year��$
��Left=�$��23��$
 Wrap=�$
��Year��$	��Top=�$	��267��$��
10,291,0,0q����	#FFD1DAE5�� -    ��Name$
 Term��$
��Left=�$	��Top=�$	��267��$��279,291,0,0q� �� SelectedIndex$ 0��.@��� $��Select Term���� $
��Fall���� $��Spring���� -    ��Name$ Generate��$��Generate��$
��Left=�$	��Top=�$��75��$��
10,356,0,0q��� -   $  Select_TemplateCertificate��$��Select File��$
��Left=�$	��Top=�$��75��$��551,207,0,0q�$��23���� -	   $ Select_InputStudentFile��$��Select File��$
��Left=�$	��Top=�$��75��$��551,235,0,0q� J� RenderTransformOrigin$ 0.453,0.518&�$��23���� -
   $ Select_OutputLocation��$��Select Folder��$
��Left=�$	��Top=�$��75��$��551,263,0,0q�$��23���� -    ��Name$ GenerateComplete��$
��Left=�$
��Wrap=�$	��Top=�$��101,356,0,0q�$��14(��� -   $
 Name��$
��Left=�$��23��$
 Wrap=�$��	Your Name��$	��Top=�$	��267��$��
10,318,0,0q����	#FFD1DAE5�� -   $ Email��$
��Left=�$��23��$
 Wrap=�$��
Your Email��$	��Top=�$	��267��$��279,318,0,0q����	#FFD1DAE5