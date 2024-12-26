// Function to copy text to the clipboard
export const copyToClipboard = (text) => {
    try {
        navigator.clipboard.writeText(text);
        alert("Shortened URL copied to clipboard!");
    } catch (error) {
        console.error("Failed to copy to clipboard:", error);
        alert("Failed to copy the URL. Please try again.");
    }
};