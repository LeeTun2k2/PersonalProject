export type TFormItem = {
    label: string;
    field: string;
    required: boolean;
    type: 'text' | 'email' | 'password' | 'number' | 'date' | 'textarea' | 'select' | 'checkbox' | 'radio';
    autoComplete?: 'on' | 'off' | 'name' | 'email' | 'current-password' | 'new-password' | 'street-address' | 'postal-code' | 'tel' | 'country' | 'organization';
    options?: Array<{
      label: string;
      value: string;
    }>;
    placeholder?: string;
    minLength?: number;
    maxLength?: number;
    pattern?: string;
};