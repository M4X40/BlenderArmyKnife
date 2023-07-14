import tkinter as tk
from urllib.request import urlopen
import win32clipboard
import webbrowser

def popup(TopLevel, Title, Geometry, Windowbg, MSG, TextBG, TextFG):
    #print(f"Popup made: {TopLevel}, {Title}, {Geometry}, {Windowbg}, {MSG}, {TextBG}, {TextFG}")
    popup = tk.Toplevel(TopLevel)
    popup.wm_title(Title)
    popup.geometry(Geometry)
    popup.config(bg=Windowbg)
    msg = tk.Label(popup, text=MSG, bg=TextBG, fg=TextFG)
    msg.pack()
    def okay():
        popup.destroy()
    ok_button = tk.Button(popup, text="Okay", command=okay, bg="#c9d1d9")
    ok_button.pack(expand=True)

def copy(Script):
    script = str(urlopen(Script).read().decode('utf8')) 
    win32clipboard.OpenClipboard()
    win32clipboard.EmptyClipboard()
    win32clipboard.SetClipboardText(script, 13)
    win32clipboard.CloseClipboard()

def udump_importer():
    importer_window = tk.Toplevel(root)
    importer_window.title("UDump Importer")
    importer_window.geometry("350x100")
    importer_window.config(bg="#0d1117")

    def yes():
        copy('https://raw.githubusercontent.com/M4X40/UDumptoBlender/main/importer.py')
        popup(root, "UDump Importer", "150x75", "#0d1117", "Copied to Clipboard!", "#0d1117", "#c9d1d9")
        importer_window.destroy()

    def no():
        webbrowser.open("https://github.com/ZenCreates/Fnaf99GatorGames")
        importer_window.destroy()
        
    top_pad = tk.Frame(importer_window, bg="#0d1117", width=350, height=20)
    top_pad.pack(side="top")

    label = tk.Label(importer_window, text="Do you currently have ZenCreates/Fnaf99GatorGames?", bg="#0d1117", fg="#c9d1d9")
    label.pack(side="top")

    yes_button = tk.Button(importer_window, text="Yes", command=yes, bg="#c9d1d9")
    yes_button.pack(side="left", expand=True)

    no_button = tk.Button(importer_window, text="No", command=no, bg="#c9d1d9")
    no_button.pack(side="right", expand=True)

def find_replace_materials():
    copy('https://raw.githubusercontent.com/M4X40/BlenderTools/scripts/findreplacematerial.py')
    popup(root, "Find-Replace Materials", "150x75", "#0d1117", "Copied to Clipboard!", "#0d1117", "#c9d1d9")

def mat_uv_duplicator():
    copy('https://raw.githubusercontent.com/M4X40/BlenderTools/scripts/Mat-UV_Looping.py')
    popup(root, "Mat-UV Duplicator", "150x75", "#0d1117", "Copied to Clipboard!", "#0d1117", "#c9d1d9")

def find_node_type():
    copy('https://raw.githubusercontent.com/M4X40/BlenderTools/scripts/FindNodeType.py')
    popup(root, "Find Node Type", "150x75", "#0d1117", "Copied to Clipboard!", "#0d1117", "#c9d1d9")

def group_to_pbsdf():
    copy('https://raw.githubusercontent.com/M4X40/BlenderTools/scripts/GroupToPBSDF.py')
    popup(root, "Group to Principled BSDF", "150x75", "#0d1117", "Copied to Clipboard!", "#0d1117", "#c9d1d9")

def remove_mat_clones():
    copy('https://raw.githubusercontent.com/M4X40/BlenderTools/scripts/RemoveMaterialClones.py')
    popup(root, "Remove Material Clones", "150x75", "#0d1117", "Copied to Clipboard!", "#0d1117", "#c9d1d9")


root = tk.Tk()
root.title("M4X4's Blender Tools")
root.geometry("290x168")
root.config(bg="#0d1117")

udump_importer_button = tk.Button(root, text="UDump Importer", command=udump_importer, bg="#c9d1d9")
udump_importer_button.pack()

find_replace_materials_button = tk.Button(root, text="Find/Replace Materials", command=find_replace_materials, bg="#c9d1d9")
find_replace_materials_button.pack()

mat_uv_duplicator_button = tk.Button(root, text="Mat-UV Duplicator", command=mat_uv_duplicator, bg="#c9d1d9")
mat_uv_duplicator_button.pack()

find_node_type_button = tk.Button(root, text="Find Node Type", command=find_node_type, bg="#c9d1d9")
find_node_type_button.pack()

group_to_pbsdf_button = tk.Button(root, text="Group to Principled BSDF", command=group_to_pbsdf, bg="#c9d1d9")
group_to_pbsdf_button.pack()

remove_mat_clones_button = tk.Button(root, text="Remove Mat Clones", command=remove_mat_clones, bg="#c9d1d9")
remove_mat_clones_button.pack()

root.mainloop()
