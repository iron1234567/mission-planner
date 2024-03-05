import tkinter as tk

def display_message():
    messagebox.showinfo("Message", "Hello from Tkinter!")

root = tk.Tk()
root.geometry("200x100")
root.title("Tkinter App")

button = tk.Button(root, text="Click Me", command=display_message)
button.pack(pady=20)

root.mainloop()
