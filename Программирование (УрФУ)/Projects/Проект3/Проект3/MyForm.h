#pragma once

namespace Проект3 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::OpenFileDialog^  openFileDialog1;
	protected: 


	private: AxWMPLib::AxWindowsMediaPlayer^  axWindowsMediaPlayer1;
	private: System::Windows::Forms::MenuStrip^  menuStrip1;
	private: System::Windows::Forms::ToolStripMenuItem^  asdq2eToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  awrqrqToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  sadasfToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  toolStripMenuItem2;

	protected: 



	protected: 

	protected: 

	private:
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm::typeid));
			this->openFileDialog1 = (gcnew System::Windows::Forms::OpenFileDialog());
			this->axWindowsMediaPlayer1 = (gcnew AxWMPLib::AxWindowsMediaPlayer());
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->asdq2eToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->awrqrqToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->sadasfToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripMenuItem2 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axWindowsMediaPlayer1))->BeginInit();
			this->menuStrip1->SuspendLayout();
			this->SuspendLayout();
			// 
			// openFileDialog1
			// 
			this->openFileDialog1->FileName = L"openFileDialog1";
			// 
			// axWindowsMediaPlayer1
			// 
			this->axWindowsMediaPlayer1->Dock = System::Windows::Forms::DockStyle::Left;
			this->axWindowsMediaPlayer1->Enabled = true;
			this->axWindowsMediaPlayer1->Location = System::Drawing::Point(0, 24);
			this->axWindowsMediaPlayer1->Name = L"axWindowsMediaPlayer1";
			this->axWindowsMediaPlayer1->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axWindowsMediaPlayer1.OcxState")));
			this->axWindowsMediaPlayer1->Size = System::Drawing::Size(224, 375);
			this->axWindowsMediaPlayer1->TabIndex = 1;
			// 
			// menuStrip1
			// 
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) {this->asdq2eToolStripMenuItem});
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(578, 24);
			this->menuStrip1->TabIndex = 2;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// asdq2eToolStripMenuItem
			// 
			this->asdq2eToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) {this->awrqrqToolStripMenuItem});
			this->asdq2eToolStripMenuItem->Name = L"asdq2eToolStripMenuItem";
			this->asdq2eToolStripMenuItem->Size = System::Drawing::Size(56, 20);
			this->asdq2eToolStripMenuItem->Text = L"asdq2e";
			// 
			// awrqrqToolStripMenuItem
			// 
			this->awrqrqToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {this->sadasfToolStripMenuItem, 
				this->toolStripMenuItem2});
			this->awrqrqToolStripMenuItem->Name = L"awrqrqToolStripMenuItem";
			this->awrqrqToolStripMenuItem->Size = System::Drawing::Size(152, 22);
			this->awrqrqToolStripMenuItem->Text = L"awrqrq";
			// 
			// sadasfToolStripMenuItem
			// 
			this->sadasfToolStripMenuItem->Name = L"sadasfToolStripMenuItem";
			this->sadasfToolStripMenuItem->Size = System::Drawing::Size(152, 22);
			this->sadasfToolStripMenuItem->Text = L"sadasf";
			// 
			// toolStripMenuItem2
			// 
			this->toolStripMenuItem2->Name = L"toolStripMenuItem2";
			this->toolStripMenuItem2->Size = System::Drawing::Size(152, 22);
			this->toolStripMenuItem2->Text = L"123142";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(578, 399);
			this->Controls->Add(this->axWindowsMediaPlayer1);
			this->Controls->Add(this->menuStrip1);
			this->MainMenuStrip = this->menuStrip1;
			this->Name = L"MyForm";
			this->Text = L"Плеер";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axWindowsMediaPlayer1))->EndInit();
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) 
			 {

			 }
	private: System::Void openToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) 
			 {
				 

			 }
};
}
