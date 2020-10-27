import templateGroups from './templateGroups';

const TemplateBlocks = (bm) => {
    templateGroups.forEach(template => {
        bm.add(template.Name).set({
            label: template.Label,
            category: template.Category,
            content: `${template.Content}`,
        });
    });
};

export default TemplateBlocks;