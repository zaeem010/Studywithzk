$(document).ready(function () {
    ClassicEditor.create(document.querySelector('#editor'), {
            
	}).plugins.addExternal('ckeditor_wiris', 'https://www.wiris.net/demo/plugins/ckeditor/', 'plugin.js')
		.config.toolbar_Full.push({ name: 'wiris', items: ['ckeditor_wiris_formulaEditor', 'ckeditor_wiris_formulaEditorChemistry'] })
		.then(editor => {
			window.editor = editor;
		})
		.catch(err => {
			console.error(err.stack);
		});
});