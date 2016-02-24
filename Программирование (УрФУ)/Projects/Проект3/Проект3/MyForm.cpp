#include "MyForm.h"
//#include <SFML/Graphics.hpp>;

using namespace System;
using namespace System::Windows::Forms;

[STAThread]
void Main(array<String^>^args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	Проект3::MyForm form;
	Application::Run(%form);
}

