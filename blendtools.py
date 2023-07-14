import tkinter as tk
from tkinter.messagebox import showinfo
from urllib.request import urlopen
import win32clipboard
import webbrowser

def udump_importer():
    importer_window = tk.Toplevel(root)
    importer_window.title("UDump Importer")
    importer_window.geometry("350x100")
    importer_window.config(bg="#0d1117")

    def yes():
        script = str(urlopen('https://raw.githubusercontent.com/M4X40/UDumptoBlender/main/importer.py').read().decode('utf8')) 
        win32clipboard.OpenClipboard()
        win32clipboard.EmptyClipboard()
        win32clipboard.SetClipboardText(script, 13)
        win32clipboard.CloseClipboard()
        complete_popup()

    def no():
        webbrowser.open("https://github.com/ZenCreates/Fnaf99GatorGames")
        importer_window.destroy()
    
    def complete_popup():
        popup = tk.Toplevel(importer_window)
        popup.wm_title("Done!")
        popup.geometry("150x75")
        popup.config(bg="#0d1117")
        msg = tk.Label(popup, text="Copied to Clipboard!", bg="#0d1117", fg="#c9d1d9")
        msg.pack()
        def okay():
            popup.destroy()
            importer_window.destroy()
        ok_button = tk.Button(popup, text="Okay", command=okay, bg="#c9d1d9")
        ok_button.pack(expand=True)

    
    top_pad = tk.Frame(importer_window, bg="#0d1117", width=350, height=20)
    top_pad.pack(side="top")

    label = tk.Label(importer_window, text="Do you currently have ZenCreates/Fnaf99GatorGames?", bg="#0d1117", fg="#c9d1d9")
    label.pack(side="top")

    yes_button = tk.Button(importer_window, text="Yes", command=yes, bg="#c9d1d9")
    yes_button.pack(side="left", expand=True)

    no_button = tk.Button(importer_window, text="No", command=no, bg="#c9d1d9")
    no_button.pack(side="right", expand=True)

def find_replace_materials():
    print("Find/Replace Materials button clicked")
def mat_uv_duplicator():
    print("Mat/UV Duplicator button clicked")
def find_node_type():
    print("Find Node Type button clicked")
def group_to_pbsdf():
    print("Group to PBSDF button clicked")
def split_orm():
    print("Split ORM button clicked")
def remove_mat_clones():
    print("Remove Mat Clones button clicked")

root = tk.Tk()
root.title("M4X4's Blender Tools")
root.geometry("290x193")
root.config(bg="#0d1117")

udump_importer_button = tk.Button(root, text="UDump Importer", command=udump_importer, bg="#c9d1d9")
udump_importer_button.pack()

find_replace_materials_button = tk.Button(root, text="Find/Replace Materials", command=find_replace_materials, bg="#ea99a2")
find_replace_materials_button.pack()

mat_uv_duplicator_button = tk.Button(root, text="Mat-UV Duplicator", command=mat_uv_duplicator, bg="#ea99a2")
mat_uv_duplicator_button.pack()

find_node_type_button = tk.Button(root, text="Find Node Type", command=find_node_type, bg="#ea99a2")
find_node_type_button.pack()

group_to_pbsdf_button = tk.Button(root, text="Group to PBSDF", command=group_to_pbsdf, bg="#ea99a2")
group_to_pbsdf_button.pack()

split_orm_button = tk.Button(root, text="Split ORM", command=split_orm, bg="#ea99a2")
split_orm_button.pack()

remove_mat_clones_button = tk.Button(root, text="Remove Mat Clones", command=remove_mat_clones, bg="#ea99a2")
remove_mat_clones_button.pack()

root.mainloop()